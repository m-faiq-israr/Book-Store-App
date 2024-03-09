﻿using _1.BookStoreApp.Models.Domain;
namespace _1.BookStoreApp.Repositories.Abstract

{
    public interface IGenreService
    {
        bool Add(Genre model);

        bool Update(Genre model);

        bool Delete(int id);

        Genre FindById(int id);

        IEnumerable<Genre> GetAll();    




    }
}
