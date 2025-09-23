// src/App.js
import { useTheme } from './index';

function App(){
  const { theme, toggleTheme } = useTheme();

  const appStyles = {
    backgroundColor: theme === 'light' ? 'white' : 'black',
    color: theme === 'light' ? 'black' : 'white',
    height: '100vh',
    display: 'flex',
    flexDirection: 'column',
    justifyContent: 'center',
    alignItems: 'center',
  };

  const buttonStyles = {
    padding: '10px 20px',
    fontSize: '16px',
    cursor: 'pointer',
    marginTop: '20px',
    
  };

  return (
    <div style={appStyles}>
      <h1>Hello students! Welcome to my new show.</h1>
      <button onClick={toggleTheme} style={buttonStyles}>
        Toggle Theme
      </button>
    </div>
  );
};

export default App;
