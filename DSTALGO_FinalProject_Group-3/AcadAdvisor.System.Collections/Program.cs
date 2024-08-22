using System;
using AcadAdvisor.System.Collections;

namespace AcadAdvisor
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initializing concern types queue
            var courseOfferingQueue = new CircularQueue<StudentTicket>(10);
            var courseTransferQueue = new CircularQueue<StudentTicket>(10);
            var addDropPeriodQueue = new CircularQueue<StudentTicket>(10);
            var courseSectionQueue = new CircularQueue<StudentTicket>(10);
            var appdaetQueue = new CircularQueue<StudentTicket>(10);
            var busevalQueue = new CircularQueue<StudentTicket>(10);
            var uiuxdesQueue = new CircularQueue<StudentTicket>(10);
            var webdevtQueue = new CircularQueue<StudentTicket>(10);

            // Populate data for concern types queue
            string[] studentNames = { "Gabrielle Almirol", "Rezzylaine Estor", "Shakira Cudal", "Hazelle Gamoras", "Kurt Hacinas" };
            string[] studentIDs = { "12312728", "12312796", "12312745", "12312567", "12312573", "12324562" };
            string[] degreeCodes = { "BS-IS" };
            string[] courseCodes = { "APPDAET", "UIUXDES", "BUSEVAL", "WEBDEVT" };
            string[] concernTypes = { "Course Offering", "Course Transfer", "Course Transfer", "Course Add-Drop" };
            int[] daysLeft = { 10, 8, 6, 4, 2, 5 };
            bool[] registrarApprovalStatus = { true, false, true, true, false };

            // Populate data for sample student tickets
            var tickets = new[]
            {
                new StudentTicket(studentNames[0], studentIDs[0], degreeCodes[0], courseCodes[1], concernTypes[0], daysLeft[0], registrarApprovalStatus[0]),
                new StudentTicket(studentNames[1], studentIDs[1], degreeCodes[0], courseCodes[0], concernTypes[1], daysLeft[1], registrarApprovalStatus[1]),
                new StudentTicket(studentNames[2], studentIDs[2], degreeCodes[0], courseCodes[2], concernTypes[2], daysLeft[2], registrarApprovalStatus[2]),
                new StudentTicket(studentNames[3], studentIDs[3], degreeCodes[0], courseCodes[3], concernTypes[1], daysLeft[3], registrarApprovalStatus[3]),
                new StudentTicket(studentNames[4], studentIDs[4], degreeCodes[0], courseCodes[3], concernTypes[3], daysLeft[4], registrarApprovalStatus[4]),
            };


            // Enqueue tickets to a unified student queue
            var studentQueue = new CircularQueue<StudentTicket>(tickets.GetLength(0));
            foreach (var ticket in tickets)
            {
                studentQueue.Enqueue(ticket);
            }

            // Allocate tickets into specific queues based on concern type
            while (true)
            {
                try
                {
                    var ticket = studentQueue.Dequeue(); 

                    switch (ticket.ConcernType)
                    {
                        case "Course Offering":
                            courseOfferingQueue.Enqueue(ticket);
                            break;
                        case "Course Transfer":
                            courseTransferQueue.Enqueue(ticket);
                            break;
                        case "Course Add-Drop":
                            addDropPeriodQueue.Enqueue(ticket);
                            break;
                        case "Course Section":
                            courseSectionQueue.Enqueue(ticket);
                            break;
                        default:
                            Console.WriteLine($"Unknown concern type: {ticket.ConcernType}");
                            break;
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n--------------------------------------------- ACADEMIC ADVISOR HOMEPAGE --------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t\t\t\t\t\tMenu");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine("[1] View according to");
                Console.WriteLine("[2] Registrar Approval");
                Console.WriteLine("[3] Add/Remove Student From Course");
                Console.WriteLine("[4] Exit");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write("\nMenu Option: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string choice = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                switch (choice)
                {
                    case "1":
                        ViewAccordingToOptions(courseOfferingQueue, courseTransferQueue, addDropPeriodQueue, courseSectionQueue);
                        break;

                    case "2":
                        ProcessRegistrarApproval(courseOfferingQueue, courseSectionQueue, courseTransferQueue, addDropPeriodQueue);
                        break;

                    case "3":
                        AddRemoveStudentsFromCourse(courseOfferingQueue, courseSectionQueue, courseTransferQueue, addDropPeriodQueue, appdaetQueue, uiuxdesQueue, busevalQueue, webdevtQueue);
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nLogout from the system.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid choice. Please select a valid option.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
            }
        }

        private static void ViewAccordingToOptions(
            CircularQueue<StudentTicket> courseOfferingQueue,
            CircularQueue<StudentTicket> courseTransferQueue,
            CircularQueue<StudentTicket> addDropPeriodQueue,
            CircularQueue<StudentTicket> courseSectionQueue)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nView according to:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("[1] Time Urgent Enlistment Concern Tickets");
                Console.WriteLine("[2] Most and Least of Enlistment Concerns Inquired By Student");
                Console.WriteLine("[3] Search for Student Details");
                Console.WriteLine("[4] Exit");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write("\nOption: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                var choice = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;

                switch (choice)
                {
                    case "1":
                        // Sort and print queues by urgency
                        Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                        CircularQueue<StudentTicket>.SortQueue(courseOfferingQueue);
                        CircularQueue<StudentTicket>.SortQueue(courseTransferQueue);
                        CircularQueue<StudentTicket>.SortQueue(addDropPeriodQueue);
                        CircularQueue<StudentTicket>.SortQueue(courseSectionQueue);

                        PrintSortedQueue("Course Offering", courseOfferingQueue);
                        PrintSortedQueue("Course Transfer", courseTransferQueue);
                        PrintSortedQueue("Course Add-Drop", addDropPeriodQueue);
                        PrintSortedQueue("Course Section", courseSectionQueue);
                        Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                        break;

                    case "2":
                        // Calculate and display the min-max of the queue counts
                        var concernTypesQueue = new[] { "Course Offering", "Course Transfer", "Course Add-Drop", "Course Section" };
                        var queueCounts = new[]
                        {
                            CircularQueue<StudentTicket>.CountQueueElements(courseOfferingQueue),
                            CircularQueue<StudentTicket>.CountQueueElements(courseTransferQueue),
                            CircularQueue<StudentTicket>.CountQueueElements(addDropPeriodQueue),
                            CircularQueue<StudentTicket>.CountQueueElements(courseSectionQueue)
                        };

                        var computation = new Computation();
                        computation.MinMax(queueCounts, out int minCount, out int maxCount, out int minIndex, out int maxIndex);

                        Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nQueue with the most students -- {concernTypesQueue[maxIndex]} | {maxCount} students");
                        Console.WriteLine($"Queue with the fewest students -- {concernTypesQueue[minIndex]} | {minCount} students");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n-----------------------------------------------------------------------------------------");

                        break;

                    case "3":
                        // Search for student details by ID
                        Console.Write("\nEnter Student ID to search: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string searchID = Console.ReadLine();
                        Console.ForegroundColor= ConsoleColor.Gray;

                        var queues = new[] { courseOfferingQueue, courseTransferQueue, addDropPeriodQueue, courseSectionQueue };
                        bool found = false;
                        StudentTicket foundTicket = null;

                        foreach (var queue in queues)
                        {
                            if (Search.LinearSearch(searchID, queue, out foundTicket))
                            {
                                Console.WriteLine("\n-----------------------------------------------------------------------------------------\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Student Name: ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"{foundTicket.StudentName}");

                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Student ID: ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"{foundTicket.StudentID}");

                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Degree Code: ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"{foundTicket.DegreeCode}");

                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Course Code: ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"{foundTicket.CourseCode}");

                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Days Left: ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"{foundTicket.DaysLeft}");

                                found = true;
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                            }
                        }

                        if (!found)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNo student found with Student ID -- " + searchID);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "4":
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid choice. Please select a valid option.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
            }
        }

        private static void PrintSortedQueue(string header, CircularQueue<StudentTicket> queue)
        {
            Console.WriteLine($"\n{header}:");

            var items = queue.GetItems();
            if (items.GetLength(0) == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No students are currently in this queue.");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            foreach (var ticket in items)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{ticket.StudentName} -- Student ID: {ticket.StudentID} | Degree: {ticket.DegreeCode} | Course: {ticket.CourseCode} | Days Left: {ticket.DaysLeft}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        private static void ProcessRegistrarApproval(
            CircularQueue<StudentTicket> courseOfferingQueue,
            CircularQueue<StudentTicket> courseTransferQueue,
            CircularQueue<StudentTicket> addDropPeriodQueue,
            CircularQueue<StudentTicket> courseSectionQueue)
        {
            Console.Write("\nEnter Student ID to search for Office of the Registrar Approval of Request: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string searchID = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            var queues = new[] { courseOfferingQueue, courseTransferQueue, addDropPeriodQueue, courseSectionQueue };
            bool found = false;
            StudentTicket foundTicket = null;

            foreach (var queue in queues)
            {
                if (Search.LinearSearch(searchID, queue, out foundTicket))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (foundTicket.RegistrarApprovalStatus)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Approved, set to green
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Not Approved, set to red
                    }

                    Console.WriteLine($"\nStudent Found: {foundTicket.StudentName}, Course: {foundTicket.CourseCode}, Concern Type: {foundTicket.ConcernType}, Registrar Approval: {(foundTicket.RegistrarApprovalStatus ? "Approved" : "Not Approved")}");
                    found = true;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
            }

            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No student found with the given Student ID.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        private static void AddRemoveStudentsFromCourse(
            CircularQueue<StudentTicket> courseOfferingQueue,
            CircularQueue<StudentTicket> courseSectionQueue,
            CircularQueue<StudentTicket> courseTransferQueue,
            CircularQueue<StudentTicket> addDropPeriodQueue,
            CircularQueue<StudentTicket> appdaetQueue,
            CircularQueue<StudentTicket> uiuxdesQueue,
            CircularQueue<StudentTicket> busevalQueue,
            CircularQueue<StudentTicket> webdevtQueue)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nChoose course to manage student approvals:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[1] APPDAET");
            Console.WriteLine("[2] UIUXDES");
            Console.WriteLine("[3] BUSEVAL");
            Console.WriteLine("[4] WEBDEVT");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("\nSelect Term Course to Manage: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string choice = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            CircularQueue<StudentTicket> selectedQueue = null;
            switch (choice)
            {
                case "1":
                    selectedQueue = appdaetQueue;
                    break;
                case "2":
                    selectedQueue = uiuxdesQueue;
                    break;
                case "3":
                    selectedQueue = busevalQueue;
                    break;
                case "4":
                    selectedQueue = webdevtQueue;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid course selection.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[1] Add Student to Course");
            Console.WriteLine("[2] Remove Student from Course");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("\nOption: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string actionChoice = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            CircularQueue<StudentTicket> approvedQueue = PopulateApprovedStudentQueue();

            switch (actionChoice)
            {
                case "1":
                    AddStudentToCourse(selectedQueue);
                    break;

                case "2":
                    RemoveStudentFromCourse(selectedQueue, approvedQueue);
                    break;

                default:
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("\nInvalid action selection.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
        }

        private static void AddStudentToCourse(CircularQueue<StudentTicket> selectedQueue)
        {
            Console.Write("Enter Student Name: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string studentName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Enter Student ID: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string studentID = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Enter Degree Code: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string degreeCode = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Enter Course Code: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string courseCode = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            if (!Search.LinearSearch(studentID, PopulateApprovedStudentQueue(), out StudentTicket foundTicket))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nStudent is not approved by the registrar and cannot be added to the course.");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            var newTicket = new StudentTicket(studentName, studentID, degreeCode, courseCode, "Course Add-Drop", 0, foundTicket.RegistrarApprovalStatus);
            selectedQueue.Enqueue(newTicket);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nStudent {studentName} successfully added to {courseCode} course queue.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void RemoveStudentFromCourse(CircularQueue<StudentTicket> selectedQueue, CircularQueue<StudentTicket> approvedQueue)
        {
            // Collect student ID to remove from the course
            Console.Write("Enter Student ID to remove: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string studentID = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            // Validation to check if the student is approved to drop the course
            if (!Search.LinearSearch(studentID, approvedQueue, out StudentTicket approvedTicket))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Student is not approved by the registrar and cannot be removed from the course.");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            // Remove if student has been approved to drop course

            if (Search.LinearSearch(studentID, selectedQueue, out StudentTicket foundTicket))
            {
                int index = -1;
                int tempIndex = 0;
                bool found = false;

                CircularQueue<StudentTicket> tempQueue = new CircularQueue<StudentTicket>(selectedQueue.GetItems().GetLength(0));

                while (true)
                {
                    try
                    {
                        var ticket = selectedQueue.Dequeue();

                        bool isMatch = true;

                        for (int j = 0; j < studentID.Length; j += 1)
                        {
                            if (j >= ticket.StudentID.Length || studentID[j] != ticket.StudentID[j])
                            {
                                isMatch = false;
                                break;
                            }
                        }

                        if (isMatch && !found)
                        {
                            index = tempIndex;
                            found = true;
                        }
                        else
                        {
                            tempQueue.Enqueue(ticket);
                            tempIndex += 1;
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }

                if (index >= 0)
                {
                    while (true)
                    {
                        try
                        {
                            var ticket = tempQueue.Dequeue();
                            selectedQueue.Enqueue(ticket);
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Student {foundTicket.StudentName} successfully removed from {foundTicket.CourseCode} course queue.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Student ID {studentID} not found approved for addition/removal to course.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        private static CircularQueue<StudentTicket> PopulateApprovedStudentQueue()
        {
            // Initialize the queue with sample data
            string[] studentNames = { "Gabrielle Almirol", "Rezzylaine Estor", "Shakira Cudal", "Hazelle Gamoras", "Kurt Hacinas" };
            string[] studentIDs = { "12312728", "12312796", "12312745", "12312567", "12312573" };
            string[] degreeCodes = { "BS-IS" };
            string[] courseCodes = { "APPDAET", "UIUXDES", "BUSEVAL", "WEBDEVT" };
            string[] concernTypes = { "Course Offering", "Course Transfer", "Course Section", "Course Add-Drop" };
            int[] daysLeft = { 10, 8, 6, 4, 2 };
            bool[] registrarApprovalStatus = { true, false, true, true, false };

            // Populate data for sample student tickets
            var tickets = new[]
            {
                new StudentTicket(studentNames[0], studentIDs[0], degreeCodes[0], courseCodes[1], concernTypes[0], daysLeft[0], registrarApprovalStatus[0]),
                new StudentTicket(studentNames[1], studentIDs[1], degreeCodes[0], courseCodes[0], concernTypes[1], daysLeft[1], registrarApprovalStatus[1]),
                new StudentTicket(studentNames[2], studentIDs[2], degreeCodes[0], courseCodes[2], concernTypes[2], daysLeft[2], registrarApprovalStatus[2]),
                new StudentTicket(studentNames[3], studentIDs[3], degreeCodes[0], courseCodes[3], concernTypes[1], daysLeft[3], registrarApprovalStatus[3]),
                new StudentTicket(studentNames[4], studentIDs[4], degreeCodes[0], courseCodes[3], concernTypes[3], daysLeft[4], registrarApprovalStatus[4]),
            };

            CircularQueue<StudentTicket> approvedQueue = new CircularQueue<StudentTicket>(tickets.GetLength(0));


            foreach (var ticket in tickets)
            {
                if (ticket.RegistrarApprovalStatus)
                {
                    approvedQueue.Enqueue(ticket);
                }
            }
            return approvedQueue;
        }
    }
}
