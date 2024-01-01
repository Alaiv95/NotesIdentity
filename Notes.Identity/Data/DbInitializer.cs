﻿namespace Notes.Identity.Data;

public class DbInitializer
{
    public static void Initialize(AuthDbContext authDbContext)
    {
        authDbContext.Database.EnsureCreated();
    } 
}
