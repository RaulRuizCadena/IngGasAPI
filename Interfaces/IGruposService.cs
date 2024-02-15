using IngGasAPI.Models;

namespace IngGasAPI.Interfaces
{
    public interface IGruposService
    {
        public Task<List<Grupos>> ListaGrupos(string cadOrden, int MSSoapWS);
        public Task<IEnumerable<Grupos>> GetGrupoByIdAsync(int Id);
        public Task<int> AddGrupo(Grupos grupo);
        public Task<int> AddGrupo2(int gruId, string gruNombre, string gruTipo, int usuId);
        public Task<int> UpdateGrupo(int gruId, string gruNombre, string gruTipo, int usuId);
        public Task<int> EditGrupo(Grupos grupo);
        public Task<int> DeleteGrupo(int gruId);
    }
}
