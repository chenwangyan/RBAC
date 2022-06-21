import Vue from 'vue'
import VueRouter from 'vue-router'
import HomeView from '../views/HomeView.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/about',
    name: 'about',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
  },,
  {
    path: '/Menu',
    name: 'Menu',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/Menu/Menu.vue')
  }
]

const router = new VueRouter({
  routes
})

//导航守卫
// router.beforeEach((to, from, next) => {
//   var loginname=window.sessionStorage.getItem("")??"";
//   if (to.name !== 'Login'&& loginname.length==0)
//   {
//     next({name:'Login'});
//   }
//    next()
// })

export default router


