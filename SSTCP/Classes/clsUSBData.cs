using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSTCP.Classes
{
    class clsUSBData
    {
        #region Private Fields

        private bool _Error = false;
        private string _ErrorMessage = string.Empty;
        private byte[] _Data;

        #endregion

        #region Constructor

        public clsUSBData(byte[] Data, int Length)
        {
            _Data = GetUSBData(Data, Length);
        }

        #endregion

        #region Public Properties

        public string ErrorMessage { get { return _ErrorMessage; } }
        public bool Error { get { return _Error; } }
        public byte[] USBDeviceData { get { return _Data; } }
        #endregion

        #region Private Methods

        private byte[] GetUSBData(byte[] Data, int Length)
        {
            if (Data != null && Data.Length == Length)
            {
                _Error = false;
                return Data;
            }
            else
            {
                _Error = true;
                _ErrorMessage = "Data length is invalid";
                return null;
            }
        }

        #endregion
    }
}
