using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Prizm.Main.Commands
{
   public class CommandInfo : IDisposable
   {
      ICommand executor = null;
      IAttacher attacher = null;

      private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CommandInfo));

      private readonly Action RefreshControlsState;

      public CommandInfo() { }

      public CommandInfo(Action refreshControlsState)
          : this()
      {
          this.RefreshControlsState = refreshControlsState;  
      }

      public CommandInfo Executor(ICommand executor)
      {
         this.executor = executor;
         return this;
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

         attacher = new SimpleButtonAttacher(executor, button, RefreshControlsState);
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
          private readonly Action RefreshControlsState;

         public SimpleButtonAttacher(ICommand command, SimpleButton btn) : base(command, btn)
         {
            Attach();
         }

         public SimpleButtonAttacher(ICommand command, SimpleButton btn, Action refreshControlsState)
             : this(command, btn)
         {
             this.RefreshControlsState = refreshControlsState;
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
            component.Enabled = command.CanExecute();
         }

         void btn_Click(object sender, EventArgs e)
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
                 Program.MainForm.Enabled = false;
                 notify.ShowProcessing();
                 
                 command.Execute();
             }
             finally
             {
                 notify.HideProcessing();
                 Program.MainForm.Enabled = true;
                 if (RefreshControlsState != null) RefreshControlsState();
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
            component.Enabled = command.CanExecute();
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

      class ClosureCommand : ICommand
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

         public void Execute()
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

         public bool CanExecute()
         {
            return canExecute != null ? canExecute() : false;
         }

      }

      #endregion // ClosureCommand

      #endregion // Internal implementation


   }
}
