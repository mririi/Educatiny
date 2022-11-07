namespace Educatiny
{
    class ExtendedButton : System.Windows.Forms.Button //this inherits from button
    {

        //constructor
        public ExtendedButton()
        {  /*you dont need to do anything here*/  }


        //add public property
        private string myval;
        public string _myval
        {
            get { return myval; }
            set { myval = value; }
        }
    }
}