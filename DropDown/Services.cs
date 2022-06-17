using DropDown.Models;

namespace DropDown
{
    public class Services
    {
        public List<CountryMaster> Getall()
        {
            var Country = new List<CountryMaster>();
             var Context = new StudentPerformanceManagementContext();
            return Context.CountryMasters.ToList();
        }

        public List<StateMaster> Getalls(string ID="0")
        {
          
            var Context = new StudentPerformanceManagementContext();
            return (from s in Context.StateMasters
                    where s.StateId.Equals(ID)  
                    where ID.Equals("0")
                    select s).ToList();
        }
    }
}
