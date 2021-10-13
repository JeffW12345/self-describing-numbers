# Python solution

def is_self_describing_number(to_check):
    as_str = str(to_check)
    numToFrequencyDict = {}
    for num in as_str:
        if int(num) in numToFrequencyDict:
            numToFrequencyDict[int(num)] += 1
        else:
            numToFrequencyDict[int(num)] = 1
    for i in range(len(as_str)):
        if int(as_str[i]) == 0 and i not in numToFrequencyDict:
            continue
        if int(as_str[i]) != numToFrequencyDict[i]:
            return False
    return True


print(is_self_describing_number(2020)) # Expected to return true
print(is_self_describing_number(2021)) # Expected to return false
