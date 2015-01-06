using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PC_Cleaner
{
    /// <summary>
    /// Interaction logic for wndRegisterNow.xaml
    /// </summary>
    public partial class wndRegisterNow : MetroWindow
    {
        public wndRegisterNow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateForm())
            {

                try
                {
                    SendEmail();
                    MessageBox.Show("Thank you for registration. Our support team will contact you soon.");
                    this.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }

        private bool ValidateForm()
        {
            bool isError = false;

            ClearControlError(txtbxFname);
            ClearControlError(txtbxLname);
            ClearControlError(txtbxPhone);
            ClearControlError(txtbxEmail);

            if (string.IsNullOrEmpty(txtbxFname.Text))
            {
                isError = true;
                SetControlError(txtbxFname, "Required");
            }

            if (string.IsNullOrEmpty(txtbxLname.Text))
            {
                isError = true;
                SetControlError(txtbxLname, "Required");
            }

            if (string.IsNullOrEmpty(txtbxPhone.Text))
            {
                isError = true;
                SetControlError(txtbxPhone, "Required");
            }

            if (string.IsNullOrEmpty(txtbxEmail.Text))
            {
                isError = true;
                SetControlError(txtbxEmail, "Required");
            }

            if (!string.IsNullOrEmpty(txtbxPhone.Text) && txtbxPhone.Text.Length != 10)
            {
                isError = true;
                SetControlError(txtbxPhone, "Invalid");
            }

            if (!string.IsNullOrEmpty(txtbxEmail.Text) && !IsValidEmailAddress(txtbxEmail.Text))
            {
                isError = true;
                SetControlError(txtbxEmail, "Invalid Email ID");
            }

            return isError;
        }

        public void SetControlError(Control control, string errorMessage)
        {
            ControlValidationHelper validationHelper =
                        new ControlValidationHelper(errorMessage);

            control.SetBinding(Control.TagProperty, new Binding("ValidationError")
            {
                Mode = BindingMode.TwoWay,
                NotifyOnValidationError = true,
                ValidatesOnExceptions = true,
                UpdateSourceTrigger = UpdateSourceTrigger.Explicit,
                Source = validationHelper
            });

            // this line throws a ValidationException with your custom error message;
            // the control will catch this exception and switch to its "invalid" state
            control.GetBindingExpression(Control.TagProperty).UpdateSource();
        }

        public static void ClearControlError(Control control)
        {
            BindingExpression b = control.GetBindingExpression(Control.TagProperty);

            if (b != null)
            {
                ((ControlValidationHelper)b.DataItem).ThrowValidationError = false;
                b.UpdateSource();
            }
        }

        public bool IsValidEmailAddress(string strEmail)
        {
            String regxPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(strEmail, regxPattern);
        }



        private void SendEmail()
        {
            MailMessage Emailmsg = new MailMessage();
            Emailmsg.From = new MailAddress("receipt.compusoft@gmail.com", "Total PC Cleaner Team");

            Emailmsg.To.Add("receipt.compusoft@gmail.com");
            //Emailmsg.Bcc.Add("ari@dbliss.com");
            Emailmsg.Subject = "Total PC Cleaner - New Registration Received";
            var htmlBody = "";
            htmlBody = @" <html>
        <table>
            <tr>
                <td>
                    First Name:
                </td>
                <td>
                    " + txtbxFname.Text + @"
                </td>
            </tr> 
<tr>
                <td>
                    Last Name:
                </td>
                <td>
" + txtbxLname.Text + @"
                </td>
            </tr>
            <tr>
                <td>
                    Phone:
                </td>
                <td>
" + txtbxPhone.Text + @"
                </td>
            </tr>
            <tr>
<tr>
                <td>
                    Email:
                </td>
                <td>
" + txtbxEmail.Text + @"
                </td>
            </tr>
            <tr>
                <td>
                   Message:
                </td>
                <td>
" + txtbxMessage.Text + @"
                </td>
            </tr>
        </table></html>";

            Emailmsg.Body = htmlBody;
            Emailmsg.IsBodyHtml = true;
            Emailmsg.Priority = MailPriority.High;
            SmtpClient objClient = new SmtpClient("smtp.gmail.com", 25);
            objClient.EnableSsl = true;
            objClient.Credentials = new System.Net.NetworkCredential("receipt.compusoft@gmail.com", "Pass@123456");
            objClient.Send(Emailmsg);
        }
    }
}
