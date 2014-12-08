CryptoGUI
=========
This is a work-in-progress. The core requirements have been implemented, but functionality could be improved. 
 
This is a simple interface created based on my needs when studying the book "Cryptography Engineering: Design Principles and Practical Applications". This is designed to provide generic assistance for solving some common problems, but it is by no means definitive or even guaranteed to be perfect given that I am just a student. 

Basic, not rigorous, testing was done. I designed this tool with the assumption that all input would be mostly-reasonable. A sample file, examples.txt, provides some of the problems that I found myself needing to be solved. When solving this problems myself, I did make assumptions and any assumptions - correct or otherwise - probably have seeped into this project. That is why I emphasize that this was done for my own benefit and this is certainly something that could use considerable improvement. I regret that I cannot verify the accuracy of output as I lack the expertise.

Requirements:

1. Interface that allows for the reading and entering data
2. SHA-256 and SHA-512 hashes
3. AES-256 encryption and decryption
4. Computation of a MAC for a key using HMAC with SHA-256


Proposed Features:

1. Convert raw output into hex
2. Allow for string messages to be converted to hex instead of requiring a hex message
3. A key generator
4. An IV generator
5. Helpful hints to assist user in providing correct input
