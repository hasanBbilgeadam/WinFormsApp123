namespace AjandanSistemi
{
    public class Person
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    //manager
    public class Ajanda
    {
        public List<Person> People { get; set; }

        private TextDatabase txtDb = new TextDatabase("asdas");

        public void AddPerson(Person p)
        {
            string data = p.Name;
            txtDb.UpdateRow(data);
        }
        public void DeletePerson()
        {

        }


    }
    public class Hobi
    {
    }

    public class TextDatabase
    {

        public TextDatabase(string path)
        {
                
        }

        public void UpdateRow(string data)
        {

        }

        //
        public void deleteRow(string data)
        {

        }




    }


}