using HotelMgm.Data;

namespace HotelMgm
{
    public class Seed
    {
        private readonly DataContext dataContext;

        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

    }
}
