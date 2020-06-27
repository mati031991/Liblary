namespace TestProject
{
    public class Person
    {
        public string Foranme { get;  set; }
        public string Name { get; set; }

        public Person()
        {

        }
        public Person(string forname, string name)
        {
            this.Foranme = forname;
            this.Name = name;
        }
    }
}
