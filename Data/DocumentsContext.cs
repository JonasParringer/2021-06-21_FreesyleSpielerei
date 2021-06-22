using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2021_06_21_FreesyleChaosSpielerei.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

public class DocumentsContext : DbContext
    {
        ILoggerFactory loggerFactory;
        
    
    public DocumentsContext (DbContextOptions<DocumentsContext> options)
            : base(options)
        {
        //loggerFactory = new LoggerFactory().AddConsole((categoryName, logLevel) => (logLevel == LogLevel.Information) && (categoryName == DbLoggerCategory.Database.Command.Name));
        
        //loggerFactory = new LoggerFactory().AddConsole((categoryName, LogLevel) => (LogLevel == LogLevel.Informationen) && (categoryName == DbLoggerCategory.Database.Command.Name));
        
    }

    //protected override void OnConfiguring()
    //{
    //    OptionsBuilder. 
    //}

    public DbSet<_2021_06_21_FreesyleChaosSpielerei.Models.Document> Document { get; set; }
    }
