using System;

namespace QuizApp.Models
{
    /// <summary>
    /// Lớp đại diện cho phân công bài thi cho học sinh
    /// </summary>
    public class QuizAssignment
    {
        private int id;
        private int quizId;
        private int studentId;
        private int teacherId;
        private DateTime assignedDate;
        private DateTime? dueDate;
        private int maxAttempts;
        private int currentAttempts;
        private bool isPublished;
        private bool isCompleted;

        /// <summary>
        /// ID phân công
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// ID đề thi
        /// </summary>
        public int QuizId
        {
            get { return quizId; }
            set { quizId = value; }
        }

        /// <summary>
        /// ID học sinh
        /// </summary>
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        /// <summary>
        /// ID giáo viên
        /// </summary>
        public int TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }

        /// <summary>
        /// Ngày giao bài
        /// </summary>
        public DateTime AssignedDate
        {
            get { return assignedDate; }
            set { assignedDate = value; }
        }

        /// <summary>
        /// Hạn nộp
        /// </summary>
        public DateTime? DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        /// <summary>
        /// Số lần làm tối đa
        /// </summary>
        public int MaxAttempts
        {
            get { return maxAttempts; }
            set { maxAttempts = value; }
        }

        /// <summary>
        /// Số lần đã làm
        /// </summary>
        public int CurrentAttempts
        {
            get { return currentAttempts; }
            set { currentAttempts = value; }
        }

        /// <summary>
        /// Đã public bài thi chưa
        /// </summary>
        public bool IsPublished
        {
            get { return isPublished; }
            set { isPublished = value; }
        }

        /// <summary>
        /// Đã hoàn thành chưa
        /// </summary>
        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }

        /// <summary>
        /// Constructor mặc định
        /// </summary>
        public QuizAssignment()
        {
            id = 0;
            quizId = 0;
            studentId = 0;
            teacherId = 0;
            assignedDate = DateTime.Now;
            dueDate = null;
            maxAttempts = 1;
            currentAttempts = 0;
            isPublished = false;
            isCompleted = false;
        }

        /// <summary>
        /// Constructor đầy đủ
        /// </summary>
        public QuizAssignment(int assignId, int qId, int sId, int tId,
                             int maxAtts, DateTime? due)
        {
            id = assignId;
            quizId = qId;
            studentId = sId;
            teacherId = tId;
            assignedDate = DateTime.Now;
            dueDate = due;
            maxAttempts = maxAtts;
            currentAttempts = 0;
            isPublished = false;
            isCompleted = false;
        }

        /// <summary>
        /// Kiểm tra xem đã quá hạn chưa
        /// </summary>
        public bool IsOverdue()
        {
            if (dueDate == null)
                return false;

            return DateTime.Now > dueDate;
        }

        /// <summary>
        /// Kiểm tra xem còn được làm bài không
        /// </summary>
        public bool CanAttempt()
        {
            if (!isPublished)
                return false;

            if (currentAttempts >= maxAttempts)
                return false;

            if (IsOverdue())
                return false;

            return true;
        }

        /// <summary>
        /// Tăng số lần làm
        /// </summary>
        public void IncreaseAttempt()
        {
            currentAttempts++;
        }

        /// <summary>
        /// Override ToString
        /// </summary>
        public override string ToString()
        {
            return string.Format("Quiz {0} - Student {1} ({2}/{3} lần)",
                quizId, studentId, currentAttempts, maxAttempts);
        }
    }
}