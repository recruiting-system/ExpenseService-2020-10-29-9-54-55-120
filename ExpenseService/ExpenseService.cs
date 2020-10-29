﻿using System;
using ExpenseService.Exceptions;
using ExpenseService.Expense;
using ExpenseService.Projects;

namespace ExpenseService
{
    public class ExpenseService
    {
        public static ExpenseType GetExpenseCodeByProjectTypeAndName(Project project)
        {
            if (project.ProjectType == ProjectType.INTERNAL)
            {
                return ExpenseType.INTERNAL_PROJECT_EXPENSE;
            }
            else
            {
                if (project.ProjectType == ProjectType.EXTERNAL)
                {
                    if (project.ProjectName == "Project A")
                    {
                        return ExpenseType.EXPENSE_TYPE_A;
                    }

                    if (project.ProjectName == "Project B")
                    {
                        return ExpenseType.EXPENSE_TYPE_B;
                    }

                    return ExpenseType.OTHER_EXPENSE;
                }

                throw new UnexpectedProjectTypeException("You enter invalid project type");
            }
        }
    }
}
