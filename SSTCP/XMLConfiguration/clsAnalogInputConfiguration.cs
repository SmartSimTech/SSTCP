using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections;

namespace SSTCP.XMLConfiguration
{
    [Serializable]
    public class xmlAnalogInputConfiguration
    {
        private Int32 _Input;
        private String _InputName;
        private string _CodeButtonUp;
        private string _CodeButtonDown;
        private string _InputDescription;
        private bool _InputEnabled;

        public xmlAnalogInputConfiguration(Int32 Input, String InputName, string CodeUp, string CodeDown, string Description, bool Enabled)
        {
            _Input = Input;
            _InputName = InputName;
            _CodeButtonUp = CodeUp;
            _CodeButtonDown = CodeDown;
            _InputDescription = Description;
            _InputEnabled = Enabled;
        }

        public xmlAnalogInputConfiguration()
        {

        }

        public Int32 Input
        {
            get
            {
                return (_Input);
            }
            set
            {
                _Input = value;
            }
        }

        public string InputName
        {
            get
            {
                return (_InputName);
            }
            set
            {
                _InputName = value;
            }
        }

        public string CodeUp
        {
            get
            {
                return (_CodeButtonUp);
            }
            set
            {
                _CodeButtonUp = value;
            }
        }

        public string CodeDown
        {
            get
            {
                return (_CodeButtonDown);
            }
            set
            {
                _CodeButtonDown = value;
            }
        }

        public string Description
        {
            get
            {
                return (_InputDescription);
            }
            set
            {
                _InputDescription = value;
            }
        }

        public bool Enabled
        {
            get
            {
                return (_InputEnabled);
            }
            set
            {
                _InputEnabled = value;
            }
        }
    }

    [Serializable]
    public class alAnalogInputConfiguration
    {
        //[XmlElement(typeof(xmlAnalogInputConfiguration))]
        public ArrayList alAIC;

        public alAnalogInputConfiguration()
        {
            alAIC = new ArrayList();
        }

        //[XmlInclude(typeof(xmlAnalogInputConfiguration))]
        public void Add(xmlAnalogInputConfiguration i)
        {
            alAIC.Add(i);
        }
    }
}
