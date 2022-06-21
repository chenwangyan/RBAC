using DTO;
using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rbac.Entity;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        public MenuController(IServiceMenu menus)
        {
            menu = menus;
        }

        public IServiceMenu menu { get; }

        /// <summary>
        /// 显示数据递归
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetMenuList()
        {
            return new JsonResult(menu.GetMenuList());
        }
        /// <summary>
        /// 添加数据递归
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetMenuAdd()
        {
            return new JsonResult(menu.GetMenuAdd());
        }

        /// <summary>
        /// 添加菜单数据
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetMenuAdds(Menu obj)
        {
            var t = menu.GetMenuAdd(obj);
            return Ok(t);
        }

        /// <summary>
        /// 逻辑删除
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetMenuDel(Menu obj)
        {
            return Ok(menu.GetMenuDel(obj));
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetMenuEdit(Menu obj)
        {
            return Ok(menu.Edit(obj));
        }
    }
}
