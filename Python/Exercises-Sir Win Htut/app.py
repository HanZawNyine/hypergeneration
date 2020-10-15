from functools import lru_cache
@lru_cache(maxsize=9)
def fibo(n):
    print('Calculating fib{0}'.format(n))
    return 1 if n <3 else fibo(n-1)+fibo(n-2)
print(fibo(9))
