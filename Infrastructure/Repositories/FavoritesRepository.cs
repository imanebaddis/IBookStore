
using System.Collections.Generic;
using System.Linq;//importa le estensioni LINQ per lavorae con collezioni in modo piu efficiente  
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories;


//using System.Collections.Generic; 
//Importa gli strumenti per lavorare con collezione generiche come list , IEnumerable,



{

public class FavoritesRepository : IFavoritesRepository // questq classe implementa l'interfaccia 
// IFavoritesRepository, il che segnifica che deve fornire implementazioni per i metodo 
// definiti in quell'interfaccia 
// I metodi sono utilizzati per aggiungere, aggiornare, eliminare, recuperare e ottenere tutti i favoriti 

{  

    //private readonly AppDbContext_context;

    //public CategoryRepository(AppDbContext context)
    //{
    // _context = context; 
    // }
    
    public void Add(Favorite Favorite)
    {
        // _context.Categories.Add(category);
        //_context.SaveChanges();
    }

    public void Update(Favorite Favorite)
    {
        var existingCategory = _context.Categories.Find(category.Id);
        if (existingCategory != null)
        {
            //existingCategory.Name = category.Name;
            // existingCategory.Description = category.Description;
            //_context.SaveChanges();   
           
           
           
           
           
           
        }
        
        
    }
    public void Delete(Favorite Favorite)

    {
        //var existingCategory = _context.Categories.Find(CategoryId);
        // if (existingCategory != null)

        {
            // _context.Categories.Remove(existingCategory);
            // _context.SaveChanges();
        }
    }
    
    

    public Favorite GetById(int id)

    {
        //return null;
    }

    public IEnumerable<Favorite> GetAll()
    {
        //return null;
    }
    
    
}
