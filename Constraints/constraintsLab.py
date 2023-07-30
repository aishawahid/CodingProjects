#!/usr/bin/env python3
from constraint import Problem, AllDifferentConstraint, ExactSumConstraint, InSetConstraint

# Task 1    
def Travellers(List):

    problem = Problem()
    people = ["claude", "olga", "pablo", "scott"]
    times = ["2:30", "3:30", "4:30", "5:30"]
    destinations = ["peru", "romania", "taiwan", "yemen"]
    t_variables = list(map(lambda x: "t_" + x, people))
    d_variables = list(map(lambda x: "d_" + x, people))
    problem.addVariables(t_variables, times)
    problem.addVariables(d_variables, destinations)
    problem.addConstraint(AllDifferentConstraint(), t_variables)
    problem.addConstraint(AllDifferentConstraint(), d_variables)

    # Claude is either the person leaving at 2:30 pm or the traveller leaving at 3:30 pm.
    problem.addConstraint(
         (lambda x : (x == "2:30")  or (x == "3:30")),
         ["t_claude"])

    # The person leaving at 2:30 pm is flying from Peru.
    for person in people:
        problem.addConstraint(
            (lambda x, y : (x != "2:30") or (y == "peru")),
            ["t_" + person, "d_" + person])

    # The person flying from Yemen is leaving earlier than the person flying from Taiwan.
    for person in people:
        for person2 in people:
            problem.addConstraint(
                (lambda x, y, z ,w: ((w != "taiwan") or (y != "yemen") or
                    ((x == "2:30") and ((z == "3:30") or (z == "4:30") or (z == "5:30"))) or
                    ((x == "3:30") and ((z == "4:30") or (z == "5:30"))) or
                    ((x == "4:30") and ((z == "5:30"))))),
                ["t_" + person, "d_" + person, "t_" + person2 , "d_" + person2])

    # The four travellers are Pablo, the traveller flying from Yemen, the person leaving at 2:30 pm
    # and the person leaving at 3:30 pm.

    problem.addConstraint(
        (lambda x,y: (x != "2:30") and (x != "3:30") and (y != "yemen")),
        ["t_pablo", "d_pablo"])

    for person in people:
        problem.addConstraint(
            (lambda x, y: (y != "yemen") or (x != "2:30") and (x != "3:30")),
            ["t_" + person, "d_" + person])

    # The extra constraints passed as the argument List

    for i in range(len(List)):
        problem.addConstraint(
            (lambda x, t = List[i][1]: (x == t)),
            ["t_" + List[i][0]])

    solns = problem.getSolutions()
    return solns

# Task 2
def CommonSum(n):

    sum = (n * ((n*n) + 1))/ 2
    return sum

# Task 3
def msqList(m, pairList):

    problem = Problem()
    problem.addVariables(range(0, m * m), range(1, m * m + 1))
    problem.addConstraint(AllDifferentConstraint(), range(0, m ** 2))

    # row constraints
    for row in range(m):
        problem.addConstraint(ExactSumConstraint(CommonSum(m)), [row * m+i for i in range(m)])

    # column constraints
    for col in range(m):
        problem.addConstraint(ExactSumConstraint(CommonSum(m)), [col + m*i for i in range(m)])

    # diagonal constraints
    problem.addConstraint(ExactSumConstraint(CommonSum(m)), [i for i in range(0, m*m, m+1)])
    problem.addConstraint(ExactSumConstraint(CommonSum(m)), [i for i in range(m*m-m, 0, -(m-1))])

    # pairList constraints
    for pair in pairList:
        v,p = pair[0], pair[1]
        problem.addConstraint(InSetConstraint([p]),[v])

    solns = problem.getSolutions()
    return solns

# Task 4
def pmsList(m, pairList):
    problem = Problem()
    problem.addVariables(range(0, m * m), range(1, m * m + 1))
    problem.addConstraint(AllDifferentConstraint(), range(0, m ** 2))

    # row constraints
    for row in range(m):
        problem.addConstraint(ExactSumConstraint(CommonSum(m)), [row * m + i for i in range(m)])

    # column constraints
    for col in range(m):
        problem.addConstraint(ExactSumConstraint(CommonSum(m)), [col + m * i for i in range(m)])

    # diagonal constraints
    problem.addConstraint(ExactSumConstraint(CommonSum(m)), [i for i in range(0, m * m, m + 1)])
    problem.addConstraint(ExactSumConstraint(CommonSum(m)), [i for i in range(m * m - m, 0, -(m - 1))])

    # pan-diagonal constraints
    pan_diagonal = []

    for i in range((2 * m) - 1, m ** 2, m):
        pan_diagonal.append(
            [i + (j * (m - 1)) if (i + (j * (m - 1)) < m ** 2) else (i + (j * (m - 1)) - (m ** 2)) for j in range(m)])

    for i in range(m, m * (m - 1) + 1, m):
        pan_diagonal.append(
            [(i + (j * (m + 1))) if (i + (j * (m + 1)) < m ** 2) else (i + (j * (m + 1)) - (m ** 2)) for j in range(m)])

    for diagonal in pan_diagonal:
        problem.addConstraint(ExactSumConstraint(CommonSum(m)), diagonal)

    # pairList constraints
    for pair in pairList:
        i, j = pair[0], pair[1]
        problem.addConstraint(InSetConstraint([j]), [i])

    solns = problem.getSolutions()

    return solns

# Debug
if __name__ == '__main__':
    print("debug run...")



