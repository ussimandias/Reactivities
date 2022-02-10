import { useEffect } from 'react';
import { Container } from 'semantic-ui-react';
import Navbar from './NavBar';
import ActivityDashBoard from '../../features/activities/dashboard/ActivitiesDashboard';
import { observer } from 'mobx-react-lite';
import HomePage from '../../features/home/HomePage';
import { Route, useLocation } from 'react-router-dom';
import ActivityForm from '../../features/activities/form/ActivityForm';
import ActivityDetails from '../../features/activities/details/ActivityDetails';

function App() {
  const location = useLocation();
  return (
    <>
      <Navbar />
      <Container style={{ marginTop: '7em' }}>
        <Route exact path='/' component={HomePage} />
        <Route exact path='/activities' component={ActivityDashBoard} />
        <Route path='/activities/:id' component={ActivityDetails} />
        <Route
          key={location.key}
          path={['/createActivity', '/manage/:id']}
          component={ActivityForm}
        />
      </Container>
    </>
  );
}

export default observer(App);
