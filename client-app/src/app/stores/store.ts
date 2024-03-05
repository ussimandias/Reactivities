<<<<<<< HEAD
import { createContext, useContext } from 'react';
import ActivityStore from './activityStore';
import CommonStore from './commonStore';
import UserStore from './userStore';
import ModalStore from './modalStore';

interface Store {
  activityStore: ActivityStore;
  commonStore: CommonStore;
  userStore: UserStore;
  modalStore: ModalStore;
=======
import { useContext } from 'react';
import { createContext } from 'react';
import ActivityStore from './activityStore';

interface Store {
  activityStore: ActivityStore;
>>>>>>> main
}

export const store: Store = {
  activityStore: new ActivityStore(),
<<<<<<< HEAD
  commonStore: new CommonStore(),
  userStore: new UserStore(),
  modalStore: new ModalStore(),
=======
>>>>>>> main
};

export const StoreContext = createContext(store);

export function useStore() {
  return useContext(StoreContext);
}
