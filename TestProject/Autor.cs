namespace TestProject
{
    public class Autor : Person
    {
        private string _nationality;

        public Autor()
        {

        }
        public Autor(string forname, string name, string nationality)
        {
            Foranme = forname;
            Name = name;
            this._nationality = nationality;
        }
    }
}
