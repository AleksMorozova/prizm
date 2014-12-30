﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public partial class SelectDiameterDialog : DevExpress.XtraEditors.XtraForm
    {

        public int Diameter { get; set; }

        public SelectDiameterDialog()
        {
            InitializeComponent();
            saveChosenDiameter.Enabled = false;
        }

        public SelectDiameterDialog(List<Connector> duplicates): this()
        {
            foreach (var t in duplicates)
            {
                diametersIntersection.Properties.Items.Add(t);
            }
        }

        private void diametersIntersection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diameter = ((Connector)diametersIntersection.EditValue).Diameter;
            saveChosenDiameter.Enabled = (diametersIntersection.EditValue != null);
        }
    }
}