using System;
namespace Sport
{
    public class RacingSport
    {

        private string sportCategory;

        public string getClassName()
        {
            string name = this.GetType().Name;
            return name;
        }

    }
}