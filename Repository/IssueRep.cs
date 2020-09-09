using LibraryManagement3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement3.Repository
{
    public class IssueRep : IIssueRep
    {
        private readonly LMContext db;
        public IssueRep(LMContext _db)
        {
            db = _db;
        }
        public int AddDetail(Issue obj)
        {
            db.Issues.Add(obj);
            db.SaveChanges();

            return obj.IssueNo;
        }

        public int Delete(int id)
        {
            int result = 0;

            if (db != null)
            {

                var post = db.Issues.Where(x => x.IssueNo == id).FirstOrDefault();

                if (post != null)
                {

                    db.Issues.Remove(post);
                    db.SaveChanges();
                    return 1;
                }
                return result;
            }

            return result;
        }

        public Issue GetDetail(int id)
        {
            if (db != null)
            {
                return (db.Issues.Where(x => x.IssueNo == id)).FirstOrDefault();
            }
            return null;
        }

        public List<Issue> GetDetails()
        {
            return db.Issues.ToList();
        }

        public int UpdateDetail(int id, Issue obj)
        {
            if (db != null)
            {
                var obj1 = db.Issues.Where(x => x.IssueNo == id).FirstOrDefault();
                if (obj1 != null)
                {

                    obj1.BookId = obj.BookId;
                    //obj1.IssueNo = obj.IssueNo;
                    obj1.CandidateName = obj.CandidateName;

                    db.SaveChanges();
                    return 1;
                }
                return 0;

            }

            return 0;
        }
    }
}
