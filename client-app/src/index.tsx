import ReactDOM from 'react-dom';
<<<<<<< HEAD
import 'react-calendar/dist/Calendar.css';
import 'react-toastify/dist/ReactToastify.min.css';
import 'react-datepicker/dist/react-datepicker.css';
=======
>>>>>>> main
import './app/layout/styles.css';
import App from './app/layout/App';
import reportWebVitals from './reportWebVitals';
import { store, StoreContext } from './app/stores/store';
<<<<<<< HEAD
import { Router } from 'react-router-dom';
import { createBrowserHistory } from 'history';

export const history = createBrowserHistory();

ReactDOM.render(
  <StoreContext.Provider value={store}>
    <Router history={history}>
      <App />
    </Router>
=======

ReactDOM.render(
  // <React.StrictMode>
  <StoreContext.Provider value={store}>
    <App />
>>>>>>> main
  </StoreContext.Provider>,
  document.getElementById('root')

  // </React.StrictMode>,
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
