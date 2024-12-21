import '../Menu/Menu.scss'
import projectItems from '../../data/menuItems'
import priorityItems from '../../data/priorityItems'
import navImage from '../../assets/images/nav-icon.png'
import openMenuButton from '../../assets/icons/x.svg'
import React from 'react'

const Menu = () => {
	const [chooseProject, setChooseProject] = React.useState(0)
	const [choosePriority, setChoosePriority] = React.useState(0)
	const [chooseMenu, setChooseMenu] = React.useState(0)
	const [openProjects, setOpenItem] = React.useState(true)
	const [openPriority, setOpenPriority] = React.useState(true)
	const [openMenu, setOpenMenu] = React.useState(true)

	const generalMenuItems = [
		'Главная',
		'Таймлайн',
		'Поиск',
		'Настройки',
		'Пользователи',
	]

	const clickToOpenMenu = () => {
		setOpenMenu(openMenu => !openMenu)
	}

	const clickToOpenProjects = () => {
		setOpenItem(openProjects => !openProjects)
	}

	const clickToOpenPriority = () => {
		setOpenPriority(openPriority => !openPriority)
	}

	const clickToChooseProject = index => {
		setChooseProject(index)
	}

	const clickToChoosePriority = index => {
		setChoosePriority(index)
	}

	const clickToChooseMenu = index => {
		setChooseMenu(index)
	}

	return (
		<>
			<div className='svg-open'>
				<svg
					onClick={() => clickToOpenMenu()}
					className={openMenu === true ? 'svg-open' : 'svg-hide'}
					width='32'
					height='32'
					viewBox='0 0 32 32'
					fill='none'
					xmlns='http://www.w3.org/2000/svg'
				>
					<path
						d='M12 6.66667L21.3333 16L12 25.3333'
						stroke='#FFECEC'
						stroke-width='2'
						stroke-linecap='round'
						stroke-linejoin='round'
					/>
				</svg>
			</div>

			{openMenu && (
				<div className='nav-wrapper'>
					<img
						onClick={() => clickToOpenMenu()}
						className={openMenu === true ? 'svg-close' : 'svg-hide'}
						src={openMenuButton}
						alt=''
					/>

					<nav className='navbar'>
						<div className='nav-profile'>
							<img src={navImage} alt={navImage} />
							<div className='nav-profile-text'>
								<h3>SHPAK TEAM</h3>
								<div className='nav-profile-status'>
									<svg
										width='16'
										height='16'
										viewBox='0 0 16 16'
										fill='none'
										xmlns='http://www.w3.org/2000/svg'
									>
										<path
											d='M8.00001 10V11.3333M4.00001 14H12C12.3536 14 12.6928 13.8595 12.9428 13.6095C13.1929 13.3594 13.3333 13.0203 13.3333 12.6667V8.66667C13.3333 8.31304 13.1929 7.97391 12.9428 7.72386C12.6928 7.47381 12.3536 7.33333 12 7.33333H4.00001C3.64638 7.33333 3.30724 7.47381 3.0572 7.72386C2.80715 7.97391 2.66667 8.31304 2.66667 8.66667V12.6667C2.66667 13.0203 2.80715 13.3594 3.0572 13.6095C3.30724 13.8595 3.64638 14 4.00001 14ZM10.6667 7.33333V4.66667C10.6667 3.95942 10.3857 3.28115 9.88562 2.78105C9.38553 2.28095 8.70725 2 8.00001 2C7.29276 2 6.61448 2.28095 6.11439 2.78105C5.61429 3.28115 5.33334 3.95942 5.33334 4.66667V7.33333H10.6667Z'
											stroke='#666666'
											stroke-width='2'
											stroke-linecap='round'
											stroke-linejoin='round'
										/>
									</svg>
									<p>Закрыто</p>
								</div>
							</div>
						</div>
						<nav className='navbar'>
							<ul className='main-list'>
								{generalMenuItems.map((item, index) => (
									<li
										onClick={() => clickToChooseMenu(index)}
										className={chooseMenu === index ? 'active-choose' : ''}
										key={index}
									>
										{item}
									</li>
								))}
							</ul>
						</nav>
						<div className='navbar'>
							<div className='nav-title'>
								<h4>Проекты</h4>
								<svg
									onClick={() => clickToOpenProjects()}
									className={openProjects === false ? 'rotate-svg' : ''}
									width='16'
									height='16'
									viewBox='0 0 16 16'
									fill='none'
									xmlns='http://www.w3.org/2000/svg'
								>
									<path
										d='M3.33334 9.99998L8 5.33331L12.6667 9.99998'
										stroke='#666666'
										stroke-width='2'
										stroke-linecap='round'
										stroke-linejoin='round'
									/>
								</svg>
							</div>
						</div>
						{openProjects && (
							<ul className='main-list'>
								{projectItems.map((item, index) => (
									<li
										key={item.id}
										onClick={() => clickToChooseProject(index)}
										className={chooseProject === index ? 'active-choose' : ''}
									>
										{item.title}
									</li>
								))}
							</ul>
						)}
					</nav>
					<nav className='navbar'>
						<div className='nav-title'>
							<h4>Приоритет</h4>
							<svg
								onClick={() => clickToOpenPriority()}
								className={openPriority === false ? 'rotate-svg' : ''}
								width='16'
								height='16'
								viewBox='0 0 16 16'
								fill='none'
								xmlns='http://www.w3.org/2000/svg'
							>
								<path
									d='M3.33334 9.99998L8 5.33331L12.6667 9.99998'
									stroke='#666666'
									stroke-width='2'
									stroke-linecap='round'
									stroke-linejoin='round'
								/>
							</svg>
						</div>
						{openPriority && (
							<ul className='main-list'>
								{priorityItems.map((item, index) => (
									<li
										key={index}
										onClick={() => clickToChoosePriority(index)}
										className={choosePriority === index ? 'active-choose' : ''}
									>
										{item.title}
									</li>
								))}
							</ul>
						)}
					</nav>
				</div>
			)}
		</>
	)
}

export default Menu
