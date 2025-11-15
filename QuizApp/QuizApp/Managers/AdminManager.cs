using System;
using System.Collections.Generic;
using QuizApp.Models;

namespace QuizApp.Managers
{
    public sealed class AdminManager
    {
        private static readonly AdminManager instance = new AdminManager();

        // Dictionary lưu danh sách học sinh theo ClassId
        private Dictionary<int, List<User>> studentLists;

        private AdminManager()
        {
            studentLists = new Dictionary<int, List<User>>();
        }

        public static AdminManager Instance
        {
            get { return instance; }
        }

        // Admin nhận danh sách học sinh từ giáo viên
        public void ReceiveStudentList(int classId, List<User> students)
        {
            if (!studentLists.ContainsKey(classId))
                studentLists[classId] = new List<User>();

            studentLists[classId].Clear();
            studentLists[classId].AddRange(students);
        }

        // Admin xóa danh sách học sinh khi lớp bị xóa
        public void RemoveStudentList(int classId)
        {
            if (studentLists.ContainsKey(classId))
                studentLists.Remove(classId);
        }

        // Lấy danh sách học sinh của một lớp
        public List<User> GetStudentsByClass(int classId)
        {
            if (studentLists.ContainsKey(classId))
                return studentLists[classId];
            return new List<User>();
        }

        // Xem tất cả lớp + học sinh
        public Dictionary<int, List<User>> GetAllClasses()
        {
            return studentLists;
        }
    }
}
