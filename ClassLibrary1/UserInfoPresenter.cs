using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UserInfoPresenter
    {
        private readonly IUserInfo _form;
        public UserInfoPresenter(IUserInfo form)
        {
            _form = form;
            _form.SaveAttempted += _form_SaveAttempted;
        }

        private void _form_SaveAttempted(object? sender, EventArgs e)
        {
            _form.ShowFormErrors = false;
            _form.ErrorMessage = null;
            if (string.IsNullOrEmpty(_form.FirstName))
            {
                _form.ShowFormErrors = true;
                _form.ErrorMessage += "\n First Name can't be empty";
            }
            if (string.IsNullOrEmpty(_form.Email))
            {
                _form.ShowFormErrors = true;
                _form.ErrorMessage += "\n Email can't be empty";
            }
            if (string.IsNullOrEmpty(_form.Email) && !_form.Email.Contains("@"))
            {
                _form.ShowFormErrors = true;
                _form.ErrorMessage += "\n Email must contain @ symbol";
            }
        }
    }
}
