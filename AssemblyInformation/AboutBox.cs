using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace AssemblyInformation
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors
        private Assembly _executingAssembly;
        private Assembly ExecutingAssembly
        {
            get { return _executingAssembly ?? (_executingAssembly = Assembly.GetExecutingAssembly()); }
        }

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = ExecutingAssembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(ExecutingAssembly.CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get { return ExecutingAssembly.GetName().Version.ToString(); }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = ExecutingAssembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = ExecutingAssembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = ExecutingAssembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = ExecutingAssembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys keyCode = keyData & Keys.KeyCode;
            Keys modifiers = keyData & Keys.Modifiers;

            if (keyCode == Keys.Escape && modifiers == Keys.None)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
