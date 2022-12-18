using AutoMapper;
using Catalog.Models;
using MongoDB.Driver;

namespace Catalog.Services
{
    public class CouseService
    {
        private readonly IMongoCollection<Course> _courseCollection;

        public int MyProperty { get; set; }

        private readonly IMapper _mapper;
        public CouseService()
        {
            //
        }
    }
}
