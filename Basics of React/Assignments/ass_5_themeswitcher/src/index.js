import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
import { createContext, useState, useContext } from 'react';

const ThemeContext = createContext();

export const useTheme = () => useContext(ThemeContext);

export const ThemeProvider = ({ children }) => {
  const [theme, setTheme] = useState('light');

  const toggleTheme = () => {
    setTheme((prevTheme) => (prevTheme === 'light' ? 'dark' : 'light'));
  };

  return (
    <ThemeContext.Provider value={{ theme, toggleTheme }}>
      {children}
    </ThemeContext.Provider>
  );
}

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
    <ThemeProvider>
      <App />
    </ThemeProvider>
);


