import { useState, useMemo, useCallback } from 'react';

export default function NumberListAnalyzer() {
  const [numbers, setNumbers] = useState([]);
  const [inputValue, setInputValue] = useState('');

  const { sum, largestNumber } = useMemo(() => {
    if (numbers.length === 0) {
      return { sum: 0, largestNumber: 0 };
    }

    const calculatedSum = numbers.reduce((acc, num) => acc + num, 0);
    const calculatedLargestNumber = Math.max(...numbers);

    return {
      sum: calculatedSum,
      largestNumber: calculatedLargestNumber,
    };
  }, [numbers]);

  const removeHandler = useCallback((indexToRemove) => {
    setNumbers((prevNumbers) =>
      prevNumbers.filter((index) => index !== indexToRemove)
    );
  }, [setNumbers]);

  const addNumberHandler = (e) => {
    e.preventDefault();
    const newNumber = parseInt(inputValue, 10);

    if (!isNaN(newNumber)) {
      setNumbers((prevNumbers) => [...prevNumbers, newNumber]);
      setInputValue('');
    }
  };

  return (
    <div>
      <h1>Number List Analyzer</h1>
      <form onSubmit={addNumberHandler}>
        <input type="number" value={inputValue} onChange={(e) => setInputValue(e.target.value)} placeholder="Enter a number" className="number-input"/>
        <button type="submit">Add Number</button>
      </form>

      <div>
        <h2>Calculations</h2>
        <p><strong>Sum:</strong> {sum}</p>
        <p><strong>Largest Number:</strong> {largestNumber}</p>
      </div>

      <div>
        <h2>Number List</h2>
          {numbers.map((num, index) => (
            <p key={index}> {num}  <button onClick={() => removeHandler(index)}>Remove</button></p>))}
      </div>
    </div>
  );
};
