using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSTCP.XMLConfiguration
{
    class xmlCardConfiguration
    {
        private string _CardRevision;
        private string _CardModel;
        private string _CardName;
        private string _CardDescription;

        public string Revision
        {
            get
            {
                return _CardRevision;
            }
            set
            {
                _CardRevision = value;
            }
        }

        public string Model
        {
            get
            {
                return _CardModel;
            }
            set
            {
                _CardModel = value;
            }
        }

        public string Name
        {
            get
            {
                return _CardName;
            }
            set
            {
                _CardName = value;
            }
        }

        public string Description
        {
            get
            {
                return _CardDescription;
            }
            set
            {
                _CardDescription = value;
            }
        }
    }
}
