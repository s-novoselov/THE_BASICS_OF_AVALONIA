using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentPresenter
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private string? _statusValue;
        public string? StatusValue
        {
            get
            {
                return this._statusValue;
            }
            private set
            {
                if (this._statusValue == value)
                {
                    return;
                }

                this._statusValue = value;
                this.OnPropertyChanged(nameof(StatusValue));
                this.OnPropertyChanged(nameof(CanEnter));
            }
        }

        private string? _loginValue;
        public string? LoginValue
        {
            get
            {
                return this._loginValue;
            }
            set
            {
                if (this._loginValue == value)
                {
                    return;
                }

                this._loginValue = value;
                this.OnPropertyChanged(nameof(LoginValue));
                this.OnPropertyChanged(nameof(CanEnter));
            }
        }

        private string? _passValue;
        public string? PassValue
        {
            get
            {
                return this._passValue;
            }
            set
            {
                if (this._passValue == value)
                {
                    return;
                }

                this._passValue = value;
                this.OnPropertyChanged(nameof(PassValue));
                this.OnPropertyChanged(nameof(CanEnter));
            }
        }

        private string? _rePassValue;
        public string? RePassValue
        {
            get
            {
                return this._rePassValue;
            }
            set
            {
                if (this._rePassValue == value)
                {
                    return;
                }

                this._rePassValue = value;
                this.OnPropertyChanged(nameof(RePassValue));
                this.OnPropertyChanged(nameof(CanEnter));
            }
        }

        // CanSave is set to true when SavedValue is not the same as NewView
        // false otherwise
        //public bool CanEnter => ((PassValue != "") && (RePassValue != "") && (LoginValue != ""));
        //public bool CanEnter => LoginValue != "";
        //public bool testEnter = false;

        //public bool CanEnter => ((PassValue != "") && (RePassValue != "") && (LoginValue != ""));
        public bool CanEnter => (PassValue == RePassValue);

        //public bool CanEnter;

        //public void CanEnter1()
        //{
        //    CanEnter = false;
        //    ////testEnter = false;
        //    ////return false;
        //    ////((PassValue == RePassValue) && (RePassValue != "") && (LoginValue != ""))
        //    //if (PassValue == RePassValue) return true;
        //    //else return false;
        //}

        public void Enter()
        {
            if ((PassValue == RePassValue) && (LoginValue != "")){
                StatusValue = "Success!";
            }
        }

        public void Cancel()
        {
            //NewValue = SavedValue;
            LoginValue = "";
            PassValue = "";
            RePassValue = "";
            StatusValue = "";
        }
    }
}
