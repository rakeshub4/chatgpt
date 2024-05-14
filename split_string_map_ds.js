function countLetters(input) {
    // Map to store letter counts
    const letterCounts = new Map();

    // Convert input string to lowercase to ensure case insensitivity
    input = input.toLowerCase();

    // Loop through each character in the input string
    for (let i = 0; i < input.length; i++) {
        const c = input[i];
        // Check if the character is a letter
        if (/[a-z]/.test(c)) {
            // If the letter already exists in the map, increment its count
            if (letterCounts.has(c)) {
                letterCounts.set(c, letterCounts.get(c) + 1);
            } else {
                // If the letter doesn't exist, add it to the map with count 1
                letterCounts.set(c, 1);
            }
        }
    }

    // Output the letter counts
    letterCounts.forEach((count, letter) => {
        console.log(`Letter: ${letter}, Count: ${count}`);
    });
}

// Example usage
countLetters("Hello, World!");