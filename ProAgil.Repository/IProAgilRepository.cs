
using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRepository
    {
        //GERAL
         void Add<T>(T entity) where T : class;

         void UpDate<T>(T entity) where T : class;

         void Delete<T>(T entity) where T : class;

         Task<bool> SalveChangesAsync();

        //EVENTOS
         Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes);
         Task<Evento[]> GetAllEventoAsync(bool includePalestrantes);
         Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes);

         //PALESTRANTES
         Task<Palestrante[]> GetAllPaletrantesAsyncByName(string palestranteNome, bool includeEventos);
         Task<Palestrante> GetPalestrantesAsync(int palestranteId, bool includeEventos);


    }
}