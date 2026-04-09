using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IGroupRepository : IRepository<Group>
    {
        List<Group> GetAllByTeacher(string teacher);
        List<Group> GetAllByRoom(string room);
        List<Group> SearchByName(string name);

       
    }
}
