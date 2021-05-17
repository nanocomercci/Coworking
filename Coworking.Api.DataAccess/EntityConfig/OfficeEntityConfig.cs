﻿using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class OfficeEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<OfficeEntity> entityBuilder)
        {
            entityBuilder.ToTable("Offices");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            entityBuilder.HasOne(x => x.Admin).WithOne(x => x.Office).HasForeignKey<AdminEntity>(a => a.Id);
            entityBuilder.HasOne(x => x.Booking).WithOne(x => x.Office);

        }
    }
}