using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Prizm.Main.Documents;

namespace Prizm.Main.Commands
{
   public class CommandInfo : IDisposable
   {
      ICommand executor = null;
      IAttacher attacher = null;

      private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CommandInfo));

      public CommandInfo Executor(ICommand executor)
      {
         this.executor = executor;
         return this;
      }

      public void Modifier(IModifiable form)
      {
          attacher.AttachModifier(form);
      }

      public CommandInfo Executor(Action<object> exec, Func<object> argQuery, Func<bool> enabledPredicate)
      {
          executor = new ClosureCommand(exec, enabledPredicate, argQuery, this.RefreshState);
         return this;
      }

      public CommandInfo AttachTo(SimpleButton button)
      {
          if (executor == null)
          {
              var e = new InvalidOperationException("command executor is not specified");
              log.Error(e.Message);
              throw e;
          }

         attacher = new SimpleButtonAttacher(executor, button);
         return this;
      }

      public CommandInfo AttachTo(CheckEdit check)
      {
          if (executor == null)
          {
              var e = new InvalidOperationException("command executor is not specified");
              log.Error(e.Message);
              throw e;
          }

          attacher = new CheckEditAttacher(executor, check);
          return this;
      }

      public CommandInfo AttachTo(IAttacher attacher)
      {
         this.attacher = attacher;
         attacher.Attach();
         return this;
      }

      public CommandInfo Execute()
      {
          if (executor == null)
          {
              var e = new InvalidOperationException("executor is null");
              log.Error(e.Message);
              throw e;
          }

         if (executor.CanExecute())
         {
            Prizm.Main.Forms.IUserNotify notify = Program.Kernel.Get<Prizm.Main.Forms.IUserNotify>();
            try
            {
                notify.ShowProcessing();
                executor.Execute();
            }
            finally
            {
                notify.HideProcessing();
            }
         }
         return this;
      }

      public bool CanExecute()
      {
         return executor != null ? executor.CanExecute() : false;
      }
      
      public void RefreshState()
      {
         if (attacher != null)
            attacher.RefreshState();
      }

      public void Dispose()
      {
         if (attacher != null)
            attacher.Dispose();

         attacher = null;
         executor = null;
      }

      #region Internal implementation

      #region SimpleButtonAttacher

      class SimpleButtonAttacher : Attacher<SimpleButton>
      {
         public SimpleButtonAttacher(ICommand command, SimpleButton btn) : base(command, btn)
         {
            Attach();
         }

         public override void Attach()
         {
            Detach();
            component.Click += btn_Click;
         }

         public override void Detach()
         {
            if (component != null)
            {
               component.Click -= btn_Click;
            }
         }

         public override void RefreshState()
         {
             if(component.InvokeRequired)
             {
                 component.Invoke(new System.Windows.Forms.MethodInvoker(delegate { component.Enabled = command.CanExecute(); }));
             }
             else
             {
                 component.Enabled = command.CanExecute();
             }
            
         }

         async void btn_Click(object sender, EventArgs e)
         {
             if (command == null)
             {
                 var ex = new InvalidOperationException("command is null");
                 log.Error(ex.Message);
                 throw ex;
             }

            Prizm.Main.Forms.IUserNotify notify = Program.Kernel.Get<Prizm.Main.Forms.IUserNotify>();
            try
            {
                if(command.Validate())
                {
                    Program.IsCommandRunning = true;
                    modifier.IsFormEnabled = false;
                    notify.ShowProcessing();
                    var q = command as ICommandAsync;
                    await q.ExecuteAsync();
                    modifier.IsFormEnabled = true;
                }
            }
            finally
            {
                notify.HideProcessing();
                Program.IsCommandRunning = false;
                modifier.RefreshBinding();
            }
         }
      }

      #endregion // SimpleButtonAttacher

      #region CheckEditAttacher

      class CheckEditAttacher : Attacher<CheckEdit>
      {
          public CheckEditAttacher(ICommand command, CheckEdit check)
              : base(command, check)
         {
            Attach();
         }

         public override void Attach()
         {
            Detach();
            component.Modified += check_Modified;
         }

         public override void Detach()
         {
            if (component != null)
            {
                component.Modified -= check_Modified;
            }
         }

         public override void RefreshState()
         {
             if(component.InvokeRequired)
             {
                 component.Invoke(new System.Windows.Forms.MethodInvoker(delegate { component.Enabled = command.CanExecute(); }));
             }
             else
             {
                 component.Enabled = command.CanExecute();
             }
         }

         void check_Modified(object sender, EventArgs e)
         {
             if (command == null)
             {
                 var ex = new InvalidOperationException("command is null");
                 log.Error(ex.Message);
                 throw ex;
             }

            Prizm.Main.Forms.IUserNotify notify = Program.Kernel.Get<Prizm.Main.Forms.IUserNotify>();
            try
            {
                notify.ShowProcessing();

                command.Execute();
            }
            finally
            {
                notify.HideProcessing();
            }
         }
      }

      #endregion // CheckboxAttacher

      #region ClosureCommand

      class ClosureCommand : BaseCommand
      {
         readonly Action<object> execute;
         readonly Func<bool> canExecute;
         readonly Func<object> queryParameter;

         public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

         public ClosureCommand(Action<object> execute, Func<bool> canExecute, Func<object> queryParameter, RefreshVisualStateEventHandler refreshHandler)
         {
            this.execute = execute;
            this.canExecute = canExecute;
            this.queryParameter = queryParameter;
            RefreshVisualStateEvent += refreshHandler;
         }

         public override void Execute()
         {
             if (execute == null)
             {
                 var ex = new InvalidOperationException("execute function is null");
                 log.Error(ex.Message);
                 throw ex;
             }

            object args = queryParameter != null ? queryParameter() : null;
            execute(args);
            RefreshVisualStateEvent();
         }

         public override bool CanExecute()
         {
            return canExecute != null ? canExecute() : false;
         }

      }

      #endregion // ClosureCommand

      #endregion // Internal implementation


   }
}
