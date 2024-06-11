﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTest
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// fires INotifyPropertyChanged.PropertyChanged event
        /// </summary>
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }


        #region Status Property
        private bool _status;
        /// <summary>
        /// notifiable Boolean property - Status
        /// </summary>
        public bool Status
        {
            get
            {
                return this._status;
            }
            set
            {
                if (this._status == value)
                {
                    return;
                }

                this._status = value;
                this.OnPropertyChanged(nameof(Status));
            }
        }
        #endregion Status Property

        #region CanToggleStatus Property
        private bool _canToggleStatus = true;
        /// <summary>
        /// Controls whether Toggle Status button is enabled or not
        /// </summary>
        public bool CanToggleStatus
        {
            get
            {
                return this._canToggleStatus;
            }
            set
            {
                if (this._canToggleStatus == value)
                {
                    return;
                }

                this._canToggleStatus = value;
                this.OnPropertyChanged(nameof(CanToggleStatus));
            }
        }
        #endregion CanToggleStatus Property

        /// <summary>
        /// Toggles the status
        /// </summary>
        public void ToggleStatus()
        {
            Status = !Status;
        }

        /// <summary>
        /// Set the Status to whatever 'status' is passed
        /// </summary>
        public void SetStatus(bool status)
        {
            Status = status;
        }
    }
}
