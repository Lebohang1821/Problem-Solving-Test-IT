def find_duplicates(outcomes):
    seen = set()
    duplicates = []
    
    for outcome in outcomes:
        if outcome in seen:
            duplicates.append(outcome)
        else:
            seen.add(outcome)
    
    return duplicates

outcomes = [123456, 234567, 123347, 456789, 567890, 678901, 789012, 890123, 901234, 112233, 223344, 334455, 789012, 222234, 123347]
result = find_duplicates(outcomes)
print(result)