
========================
Python Infinite Examples
========================

# Simple Infinite Loop
while True:
    print("This is an infinite loop")

# Infinite Process with Thread
import threading

def infinite_function():
    while True:
        print("Thread is running")

thread = threading.Thread(target=infinite_function)
thread.start()

# Async Infinite Loop
import asyncio

async def infinite_async():
    while True:
        await asyncio.sleep(1)
        print("Ran again after waiting")

asyncio.run(infinite_async())