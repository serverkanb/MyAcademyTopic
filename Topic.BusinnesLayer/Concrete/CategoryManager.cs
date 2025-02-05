﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.BusinnesLayer.Abstract;
using Topic.DataAccessLayer.Abstract;
using Topic.EntityLayer.Entities;

namespace Topic.BusinnesLayer.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryServices
    {
        public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
        {
        }
    }
}
