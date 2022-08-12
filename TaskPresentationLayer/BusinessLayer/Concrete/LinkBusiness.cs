using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class LinkBusiness
    {
        GenericRepository<Link> repo = new GenericRepository<Link>();
        public List<Link> GetLink()
        {
            return repo.getAllItems();
        }
    }
}
