# Function to calculate sum of even and odd numbers
def sum_even_odd(numbers):
    even_sum = 0
    odd_sum = 0
    
    for num in numbers:
        if num % 2 == 0:
            even_sum += num
        else:
            odd_sum += num
            
    return even_sum, odd_sum

# Main program
def main():
    # Taking input from the user
    numbers = []
    print("Enter at least 5 integers:")
    while len(numbers) < 5:
        try:
            number = int(input("Enter an integer: "))
            numbers.append(number)
        except ValueError:
            print("Please enter a valid integer.")
    
    # Calculating the sum of even and odd numbers
    even_sum, odd_sum = sum_even_odd(numbers)
    
    # Displaying the results
    print(f"Sum of even numbers: {even_sum}")
    print(f"Sum of odd numbers: {odd_sum}")

# Run the program
if __name__ == "__main__":
    main()