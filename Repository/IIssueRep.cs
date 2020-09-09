using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement3.Model;

namespace LibraryManagement3.Repository
{
    public interface IIssueRep
    {
        List<Issue> GetDetails();
        Issue GetDetail(int id);
        int AddDetail(Issue obj);
        int UpdateDetail(int id, Issue obj);
        int Delete(int id);
    }
}
