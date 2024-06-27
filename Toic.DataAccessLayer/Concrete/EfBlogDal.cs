﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.DataAccessLayer.Abstract;
using Topic.DataAccessLayer.Context;
using Topic.DataAccessLayer.Reporsitories;
using Topic.EntityLayer.Entities;

namespace Topic.DataAccessLayer.Concrete
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public EfBlogDal(TopicContext context) : base(context)
        {
        }

        public List<Blog> GetBlogWithCattegories()
        {
            throw new NotImplementedException();
        }
    }
}
