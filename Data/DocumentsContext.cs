using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2021_06_21_FreesyleChaosSpielerei.Models;

    public class DocumentsContext : DbContext
    {
        public DocumentsContext (DbContextOptions<DocumentsContext> options)
            : base(options)
        {
        }

        public DbSet<_2021_06_21_FreesyleChaosSpielerei.Models.Document> Document { get; set; }
    }
