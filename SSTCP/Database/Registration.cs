using System;
using DevExpress.Xpo;

namespace SSTCP.Database
{

    public class Registration : XPObject
    {
        public string Name;
        public string Company;
        public string Key;

        public Registration()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Registration(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}