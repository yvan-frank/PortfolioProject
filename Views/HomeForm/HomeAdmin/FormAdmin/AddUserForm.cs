using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;
using Controllers.Admin;
using Controllers.SqlFilesControls;
using Controllers;
using Views.Controls.AlertControl;
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace Views.HomeForm.HomeAdmin.FormAdmin
{
    public partial class AddUserForm : Form
    {
        private SqlUtilsController combobox = new SqlUtilsController();
        private Utilisateur user = new Utilisateur();
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
           // AlertBox.Show("Abandon de la sauvegarde", AlertBox.AlertType.Info);
            this.Close();
        }

        private void FieldValidation()
        {
            try
            {
                user.Password = txtMdp.Text;
                user.Prenom = txtPrenom.Text;
                user.Email = txtEmail.Text;
                user.Address = txtadresse.Text;
                user.Telephone = int.Parse(txtTel.Text);
                user.Login = txtId.Text;
                user.Nom = txtNom.Text;
                int type = cmbProfil.SelectedIndex;

                if (user != null)
                {
                    ValidationContext context = new ValidationContext(user, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();

                    if (!Validator.TryValidateObject(user, context, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            MsgError(result.ErrorMessage);
                            return;
                        }
                    }
                    AdminController admin = new AdminController();

                    if (admin.Checkdata(user) == false)
                    {
                        
                        admin.AddUserAdmin(user, type);
                        AlertBox.Show("Insertion terminee!", AlertBox.AlertType.Success);
                        FieldInit();

                    }
                    else
                        AlertBox.Show("\n\nL'utilisateur existent déjà", AlertBox.AlertType.Warning);
                }

            }
            catch (Exception e)
            {
                MsgError(e.Message);
            }
        }

        private void FieldInit()
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTel.Text = "237";
            txtadresse.Text = string.Empty;
            txtId.Text = string.Empty;
            cmbProfil.SelectedIndex = -1;
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
           FieldValidation();
          // FieldInit();
        }

        private void MsgError(string errorMess)
        {
            lblMessage.Text = errorMess;
            lblMessage.Visible = true;
            lblMessage.ForeColor = Color.DarkRed;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            cmbProfil.Items.Add(combobox.FillComboBox());
        }
    }
}
