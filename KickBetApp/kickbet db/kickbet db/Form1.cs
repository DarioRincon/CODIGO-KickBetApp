using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kickbet_db
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        private const string V = "Male";

        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'modelDataSet.Table' Puede moverla o quitarla según sea necesario.
            this.tableTableAdapter.Fill(this.modelDataSet.Table);

        }

        private CheckBox GetGenderCheckBox()
        {
            return genderCheckBox;
        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox genderCheckBox = (CheckBox)sender;  // Cast de sender a CheckBox

            if (genderCheckBox.CheckState == CheckState.Checked)
            {
                genderCheckBox.Text = "Male"; // O el valor que desees
            }
            else if (genderCheckBox.CheckState == CheckState.Unchecked)
            {
                genderCheckBox.Text = "Female";
            }
            else
            {
                genderCheckBox.Text = "??"; // Si está en un estado indeterminado
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }