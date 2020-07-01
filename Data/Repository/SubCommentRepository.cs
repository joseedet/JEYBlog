﻿using JEYBlog.Models.Comments;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JEYBlog.Data.Repository
{
    public class SubCommentRepository : Repository<SubComment>, ICommentRepository
    {
        public SubCommentRepository(AppDbContext context) : base(context)
        {



        }
    }
}
