using System;
using System.Collections.Generic;
using QuizApp.Models;

namespace QuizApp.Managers
{
    /// <summary>
    /// Lớp quản lý phân công bài thi
    /// Sử dụng SINGLETON PATTERN
    /// </summary>
    public sealed class QuizAssignmentManager
    {
        private static readonly QuizAssignmentManager instance = new QuizAssignmentManager();
        private List<QuizAssignment> assignments;

        /// <summary>
        /// Constructor private
        /// </summary>
        private QuizAssignmentManager()
        {
            assignments = new List<QuizAssignment>();
        }

        /// <summary>
        /// Thuộc tính truy cập Instance duy nhất
        /// </summary>
        public static QuizAssignmentManager Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Danh sách phân công
        /// </summary>
        public List<QuizAssignment> Assignments
        {
            get { return assignments; }
        }

        /// <summary>
        /// Thêm phân công mới
        /// </summary>
        public bool AddAssignment(QuizAssignment assignment)
        {
            if (assignment == null)
                return false;

            assignments.Add(assignment);
            return true;
        }

        /// <summary>
        /// Xóa phân công
        /// </summary>
        public bool RemoveAssignment(int assignmentId)
        {
            for (int i = 0; i < assignments.Count; i++)
            {
                if (assignments[i].Id == assignmentId)
                {
                    assignments.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Tìm phân công theo ID
        /// </summary>
        public QuizAssignment FindAssignmentById(int assignmentId)
        {
            for (int i = 0; i < assignments.Count; i++)
            {
                if (assignments[i].Id == assignmentId)
                    return assignments[i];
            }
            return null;
        }

        /// <summary>
        /// Tìm phân công theo quiz và học sinh
        /// </summary>
        public QuizAssignment FindAssignment(int quizId, int studentId)
        {
            for (int i = 0; i < assignments.Count; i++)
            {
                QuizAssignment assign = assignments[i];

                if (assign.QuizId == quizId && assign.StudentId == studentId)
                    return assign;
            }
            return null;
        }

        /// <summary>
        /// Lấy danh sách phân công cho học sinh
        /// </summary>
        public List<QuizAssignment> GetAssignmentsForStudent(int studentId)
        {
            List<QuizAssignment> result = new List<QuizAssignment>();

            for (int i = 0; i < assignments.Count; i++)
            {
                QuizAssignment assign = assignments[i];

                if (assign.StudentId == studentId && assign.IsPublished)
                {
                    result.Add(assign);
                }
            }

            return result;
        }

        /// <summary>
        /// Lấy danh sách phân công từ giáo viên
        /// </summary>
        public List<QuizAssignment> GetAssignmentsByTeacher(int teacherId)
        {
            List<QuizAssignment> result = new List<QuizAssignment>();

            for (int i = 0; i < assignments.Count; i++)
            {
                QuizAssignment assign = assignments[i];

                if (assign.TeacherId == teacherId)
                {
                    result.Add(assign);
                }
            }

            return result;
        }

        /// <summary>
        /// Lấy danh sách phân công cho một đề thi
        /// </summary>
        public List<QuizAssignment> GetAssignmentsForQuiz(int quizId)
        {
            List<QuizAssignment> result = new List<QuizAssignment>();

            for (int i = 0; i < assignments.Count; i++)
            {
                QuizAssignment assign = assignments[i];

                if (assign.QuizId == quizId)
                {
                    result.Add(assign);
                }
            }

            return result;
        }

        /// <summary>
        /// Tính ID phân công mới
        /// </summary>
        private int GetNextAssignmentId()
        {
            int maxId = 0;

            for (int i = 0; i < assignments.Count; i++)
            {
                if (assignments[i].Id > maxId)
                {
                    maxId = assignments[i].Id;
                }
            }

            return maxId + 1;
        }

        /// <summary>
        /// Giao bài thi cho học sinh
        /// </summary>
        public bool AssignQuizToStudent(int quizId, int studentId, int teacherId,
                                        int maxAttempts, DateTime? dueDate)
        {
            // Kiểm tra đã giao chưa
            if (FindAssignment(quizId, studentId) != null)
                return false;

            QuizAssignment assignment = new QuizAssignment();
            assignment.Id = GetNextAssignmentId();
            assignment.QuizId = quizId;
            assignment.StudentId = studentId;
            assignment.TeacherId = teacherId;
            assignment.MaxAttempts = maxAttempts;
            assignment.DueDate = dueDate;
            assignment.AssignedDate = DateTime.Now;
            assignment.IsPublished = false;
            assignment.IsCompleted = false;
            assignment.CurrentAttempts = 0;

            return AddAssignment(assignment);

        }

        /// <summary>
        /// Public phân công để học sinh có thể nhìn thấy
        /// </summary>
        public bool PublishAssignment(int assignmentId)
        {
            QuizAssignment assignment = FindAssignmentById(assignmentId);

            if (assignment == null)
                return false;

            assignment.IsPublished = true;
            return true;
        }

        /// <summary>
        /// Tăng số lần làm
        /// </summary>
        public bool IncreaseAttempt(int assignmentId)
        {
            QuizAssignment assignment = FindAssignmentById(assignmentId);

            if (assignment == null)
                return false;

            if (!assignment.CanAttempt())
                return false;

            assignment.IncreaseAttempt();
            return true;
        }

        /// <summary>
        /// Lấy số lượng phân công
        /// </summary>
        public int GetAssignmentCount()
        {
            return assignments.Count;
        }

        /// <summary>
        /// Xóa tất cả phân công
        /// </summary>
        public void ClearAllAssignments()
        {
            assignments.Clear();
        }
    }
}