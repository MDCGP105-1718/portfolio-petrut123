def fib(n):
    for i in range(2, n):
        a.append(a[i-2] + a[i-1])
    print(a)


a = [0, 1]
fib(20)
