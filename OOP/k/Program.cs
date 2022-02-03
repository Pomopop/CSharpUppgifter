using System;

namespace k
{
    class Program
    {
      
        
    }




    class person
    {
        //properties
        public string FirstName {get; set;}
        public string Lastname {get; set;}
        public string Gender {get; set;}
        public DataTime DateofBirth {get; set;}
        public string isOccupied {get; set;} = false;


        class company
        {
            public string name {get; set;}
            public List<workers> workers {get; set;} = new List<workers>();


            public void hire(List<person> ListofPersons)
            {

                for(int i = 0; i < ListofPersons. Count; i++){
                
                
                worker hire = new worker();

                hire.name = ListofPersons[i].FirstName;
                worker.Add(hire);

                }
            }
        }

        class worker 
        {

        }



    }
}
