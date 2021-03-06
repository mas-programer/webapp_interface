﻿using KMSD.WebApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMSD.WebApp.Domain.Mapping
{
    public class MemberMenuMap : EntityTypeConfiguration<MemberMenuEntity>
    {
        public MemberMenuMap()
        {
            #region 表、主键
            //表
            this.ToTable("MemberMenu");

            //主键
            this.HasKey(t => t.MenuId);

            #endregion
        }
    }
}
